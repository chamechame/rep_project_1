import { Category } from "./importEnum";

export class Event{
    constructor(
        public Id: number,
        public Name: string,
        public Date: string,
        public Description: string,
        public Category: string,
        public Location: string
        ) { }

}
