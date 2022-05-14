import {TemplateRef, ViewChild} from '@angular/core';
import {Component, OnInit} from '@angular/core';
import {Event} from './event';
import {EventService} from './event.service';
import { Category } from "./importEnum";
@Component({ 
    selector: 'my-app',
    templateUrl: './app.component.html',
    providers: [EventService]
}) 
export class AppComponent implements OnInit {
    //типы шаблонов
    @ViewChild('readOnlyTemplate', {static: false}) readOnlyTemplate: TemplateRef<any>|undefined;
    @ViewChild('editTemplate', {static: false}) editTemplate: TemplateRef<any>|undefined;
        
    editedEvent: Event|null = null;
    events: Array<Event>;
    isNewRecord: boolean = false;
    statusMessage: string = "";
    constructor(private serv: EventService) {
        this.events = new Array<Event>();
    }
        
    ngOnInit() {
        this.loadEvent();
    }
        
    //загрузка мероприятий
    private loadEvent() {
        this.serv.getEvent().subscribe((data: Array<Event>) => {
                this.events = data; 
            });
    }
    // добавление мероприятий
    addEvent() {
        this.editedEvent = new Event(0,"","","","","");
        this.events.push(this.editedEvent);
        this.isNewRecord = true;
    }
     
    // редактирование мероприятий
    editEvent(event: Event) {
        this.editedEvent = new Event(event.Id, event.Name, event.Date, event.Description,event.Category, event.Location);
    }
    // загружаем один из двух шаблонов
    loadTemplate(event: Event) {
        if (this.editedEvent && this.editedEvent.Id === event.Id) {
            return this.editTemplate;
        } else {
            return this.readOnlyTemplate;
        }
    }
    // сохраняем мероприятие
    saveEvent() {
        if (this.isNewRecord) {
            // добавляем мероприятие
            this.serv.createEvent(this.editedEvent as Event).subscribe(data => {
                this.statusMessage = 'Данные успешно добавлены',
                this.loadEvent();
            });
            this.isNewRecord = false;
            this.editedEvent = null;
        } else {
            // изменяем мероприятие
            this.serv.updateEvent(this.editedEvent as Event).subscribe(data => {
                this.statusMessage = 'Данные успешно обновлены',
                this.loadEvent();
            });
            this.editedEvent = null;
        }
    }
    // отмена редактирования
    cancel() {
        // если отмена при добавлении, удаляем последнюю запись
        if (this.isNewRecord) {
            this.events.pop();
            this.isNewRecord = false;
        }
        this.editedEvent = null;
    }
    // удаление мероприятия
    deleteEvent(event: Event) {
        this.serv.deleteEvent(event.Id).subscribe(data => {
            this.statusMessage = 'Данные успешно удалены',
            this.loadEvent();
        });
    }
}