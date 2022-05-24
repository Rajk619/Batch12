import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../Models/product';
@Injectable({
  providedIn: 'root'
})
export class ProductService {

  api_path: string = 'http://localhost:30084/api/Product';
  constructor(private http: HttpClient) { }
  GetAllProducts(): Observable<Product[]> { //get all the products
      return this.http.get<Product[]>(this.api_path+'/GetAllProducts');
  }
  GetProductById(id: number): Observable<Product> { //get product by id
    return this.http.get<Product>(this.api_path+'/GetProductById/'+id);
  }
  AddProduct(item: Product): Observable<any> { //Add new procut details
    return this.http.post(this.api_path+'/AddProduct',item);
  }
  EditProduct(item: Product): Observable<any> {
    return this.http.put(this.api_path+'/EditProduct',item);
  }
  DeleteProduct(id: number): Observable<any> {
    return this.http.delete(this.api_path+'/DeleteProduct/'+id);
  }
}
