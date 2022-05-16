var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { Injectable } from '@angular/core';
import { HttpHeaders } from '@angular/common/http';
let EventService = class EventService {
    constructor(http) {
        this.http = http;
        this.url = "http://localhost:23970/api/Sobytiyes";
        this.urlPost = "http://localhost:23970/api/Sobytiyes/sobytiye";
        this.urlDel = "http://localhost:23970/api/Sobytiyes/sobytiye";
    }
    getEvent() {
        return this.http.get(this.url);
    }
    createEvent(event) {
        const myHeaders = new HttpHeaders().set("Content-Type", "application/json");
        return this.http.post(this.urlPost, JSON.stringify(event), { headers: myHeaders });
    }
    updateEvent(event) {
        const myHeaders = new HttpHeaders().set("Content-Type", "application/json");
        return this.http.put(this.url, JSON.stringify(event), { headers: myHeaders });
    }
    deleteEvent(Id) {
        return this.http.delete(this.urlDel + '/' + Id);
    }
};
EventService = __decorate([
    Injectable()
], EventService);
export { EventService };
//# sourceMappingURL=event.service.js.map