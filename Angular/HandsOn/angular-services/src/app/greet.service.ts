import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class GreetService {

  constructor() { }
  Greet(name:string):string
  {
    return 'Hello '+name;
  }
  GetFlowers():string[]
  {
    return ["Rose","Lilly","Jasmine","Tulips"]
  }
}
