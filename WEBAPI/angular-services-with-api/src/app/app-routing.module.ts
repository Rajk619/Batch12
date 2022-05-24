import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ViewAllComponent } from './Components/view-all/view-all.component';
import { AddProductComponent } from './Components/add-product/add-product.component';

const routes: Routes = [
  {path:'view-all',component:ViewAllComponent},
  {path:'add',component:AddProductComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
