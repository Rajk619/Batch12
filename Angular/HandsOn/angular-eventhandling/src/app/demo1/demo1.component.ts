import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo1',
  templateUrl: './demo1.component.html',
  styleUrls: ['./demo1.component.css']
})
export class Demo1Component implements OnInit {
title:string;
msg:string;
msg1:string;
  constructor() { }

  ngOnInit(): void {
  }
  SetTitle() //method
  {
    //set value to title
    this.title='Hello Angular Users';
  }
  Greet(n:string):void
  {
    this.msg='Hello '+n;
  }
  SetCountry(country:string)
  {
    this.msg1="You are from "+country;
  }

}
