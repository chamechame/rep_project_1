var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { ViewChild } from '@angular/core';
import { Component } from '@angular/core';
import { Event } from './event';
import { EventService } from './event.service';
let AppComponent = class AppComponent {
    constructor(serv) {
        this.serv = serv;
        this.editedEvent = null;
        this.isNewRecord = false;
        this.statusMessage = "";
        this.events = new Array();
    }
    ngOnInit() {
        this.loadEvent();
    }
    //загрузка мероприятий
    loadEvent() {
        this.serv.getEvent().subscribe((data) => {
            this.events = data;
        });
    }
    // добавление мероприятий
    addEvent() {
        this.editedEvent = new Event(0, "", "", "", "", "");
        this.events.push(this.editedEvent);
        this.isNewRecord = true;
    }
    // редактирование мероприятий
    editEvent(event) {
        this.editedEvent = new Event(event.Id, event.Name, event.Date, event.Description, event.Category, event.Location);
    }
    // загружаем один из двух шаблонов
    loadTemplate(event) {
        if (this.editedEvent && this.editedEvent.Id === event.Id) {
            return this.editTemplate;
        }
        else {
            return this.readOnlyTemplate;
        }
    }
    // сохраняем мероприятие
    saveEvent() {
        if (this.isNewRecord) {
            // добавляем мероприятие
            this.serv.createEvent(this.editedEvent).subscribe(data => {
                this.statusMessage = 'Данные успешно добавлены',
                    this.loadEvent();
            });
            this.isNewRecord = false;
            this.editedEvent = null;
        }
        else {
            // изменяем мероприятие
            this.serv.updateEvent(this.editedEvent).subscribe(data => {
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
    deleteEvent(event) {
        this.serv.deleteEvent(event.Id).subscribe(data => {
            this.statusMessage = 'Данные успешно удалены',
                this.loadEvent();
        });
    }
};
__decorate([
    ViewChild('readOnlyTemplate', { static: false })
], AppComponent.prototype, "readOnlyTemplate", void 0);
__decorate([
    ViewChild('editTemplate', { static: false })
], AppComponent.prototype, "editTemplate", void 0);
AppComponent = __decorate([
    Component({
        selector: 'my-app',
        templateUrl: './app.component.html',
        providers: [EventService]
    })
], AppComponent);
export { AppComponent };
//# sourceMappingURL=app.component.js.map