import { Component, OnInit } from '@angular/core';
import { Student } from '../student'; //importing student model
@Component({
  selector: 'app-demo2',
  templateUrl: './demo2.component.html',
  styleUrls: ['./demo2.component.css']
})
export class Demo2Component implements OnInit {
//initiate student model
student:Student;
  constructor() {
    this.student=new Student();
    //assign values to student variables
    this.student={studentId:1,studentName:'Suren',studentDob:new Date(2003,2,23),studentAddress:'BTM,Banglore'}
    // this.student.studentId=3230;
    // this.student.studentName='Ranjan';
    // this.student.studentDob=new Date(2003,2,21);
    // this.student.studentAddress='Channi,T-Nagar'
  }

  ngOnInit(): void {
  }

}
