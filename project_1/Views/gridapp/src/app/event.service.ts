import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Event} from './event';
import { Category } from "./importEnum";
@Injectable()
export class EventService{
     
    private url = "http://localhost:23970/api/Sobytiyes";
    private urlPost = "http://localhost:23970/api/Sobytiyes/sobytiye";
    private urlDel = "http://localhost:23970/api/Sobytiyes/sobytiye";

    constructor(private http: HttpClient){ }
        
    getEvent(){
        return this.http.get<Array<Event>>(this.url);
    }
    createEvent(event: Event){
        const myHeaders = new HttpHeaders().set("Content-Type", "application/json");
        return this.http.post<Event>(this.urlPost, JSON.stringify(event), {headers: myHeaders}); 
    }
    updateEvent(event: Event) {
        const myHeaders = new HttpHeaders().set("Content-Type", "application/json");
        return this.http.put<Event>(this.url, JSON.stringify(event), {headers:myHeaders});
    }
    deleteEvent(Id: number){
        return this.http.delete<Event>(this.urlDel + '/' + Id);
    }

}