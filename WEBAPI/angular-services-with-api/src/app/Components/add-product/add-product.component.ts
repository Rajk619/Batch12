import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/Models/product';
import { ProductService } from 'src/app/Services/product.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {
item:Product
  constructor(private productService:ProductService,private router:Router) { 
    this.item=new Product();
  }

  ngOnInit(): void {
  }
  Save()
  {
    //Invoking the service method add product
    this.productService.AddProduct(this.item).subscribe(data=>
      {
        console.log(data);
        
      })
      this.router.navigateByUrl('view-all');
  }
  Search()
  {
    let id=this.item.productId;
    this.productService.GetProductById(id).subscribe(res=>{
      this.item=res;
    })
  }
  Edit()
  {
    this.productService.EditProduct(this.item).subscribe(res=>{
      console.log(res);
    })
  }

}
