import { Component, OnInit } from '@angular/core';
import { GreetService } from '../greet.service';
@Component({
  selector: 'app-demo2',
  templateUrl: './demo2.component.html',
  styleUrls: ['./demo2.component.css']
})
export class Demo2Component implements OnInit {
flowers:string[];
  constructor(private greetService:GreetService) {
    this.flowers=this.greetService.GetFlowers();
   }

  ngOnInit(): void {
  }

}
