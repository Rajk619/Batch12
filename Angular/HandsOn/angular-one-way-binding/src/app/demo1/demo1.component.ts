import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo1',
  templateUrl: './demo1.component.html',
  styleUrls: ['./demo1.component.css']
})
export class Demo1Component implements OnInit {
//variable declaratons
studentId:number=32324;
studentName:string='Rohan';
studentAge:number=12;
studentCity:string='Chennai';
studentAddress="T-Nagar,Chennai";

  constructor() {
    
   }

  ngOnInit(): void {
  }

}
