import { Component, OnInit } from '@angular/core';
import { Student } from '../student';
@Component({
  selector: 'app-demo4',
  templateUrl: './demo4.component.html',
  styleUrls: ['./demo4.component.css']
})
export class Demo4Component implements OnInit {
students:Student[]
  constructor() {
    this.students=[
      {studentId:1,studentName:'Suren',
      studentDob:new Date(2003,2,23),studentAddress:'BTM,Banglore'},
      {studentId:2,studentName:'Karan',
      studentDob:new Date(2004,2,26),studentAddress:'T-Nagar,Chennai'},
      {studentId:3,studentName:'Jeson',
      studentDob:new Date(2003,3,27),studentAddress:'BTM,Banglore'},
      {studentId:4,studentName:'Abhi',
      studentDob:new Date(2003,4,28),studentAddress:'BTM,Chennai'},
    ];
   }

  ngOnInit(): void {
  }

}
