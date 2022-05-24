import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/Models/product';
import { ProductService } from 'src/app/Services/product.service';
@Component({
  selector: 'app-view-all',
  templateUrl: './view-all.component.html',
  styleUrls: ['./view-all.component.css']
})
export class ViewAllComponent implements OnInit {
products:Product[];
  constructor(private productService:ProductService) {
    //invoking GetAllProducts() services
   this.productService.GetAllProducts().subscribe(data=>{
     this.products=data;
     console.log(this.products);
   })
   }

  ngOnInit(): void {
  }
  Delete(id:number)
  {
    this.productService.DeleteProduct(id).subscribe(data=>{
      console.log(data);
    })
  }

}
