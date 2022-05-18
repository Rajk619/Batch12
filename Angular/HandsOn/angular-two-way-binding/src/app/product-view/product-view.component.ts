import { Component, OnInit } from '@angular/core';
import { Product } from '../product';
@Component({
  selector: 'app-product-view',
  templateUrl: './product-view.component.html',
  styleUrls: ['./product-view.component.css']
})
export class ProductViewComponent implements OnInit {
item:Product;
items:Product[]=[]; //products array
  constructor() {
    this.item=new Product();
  }

  ngOnInit(): void {
  }
  Save() //to add product details to the array
  {
    console.log(this.item);
    this.items.push(this.item); //add item to the array
    this.item=new Product(); //re initialize the item
    console.log(this.items);
  }

}
