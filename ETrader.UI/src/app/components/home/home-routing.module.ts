import { PropertSubmissionComponent } from './propert-submission/propert-submission.component';
import { SellerAgentComponent } from './seller-agent/seller-agent.component';
import { ProperyListComponent } from './propery-list/propery-list.component';
import { PropertyCategoryComponent } from './property-category/property-category.component';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IndexComponent } from './index/index.component';
import { PaymentComponent } from './payment/payment.component';

const routes: Routes = [
  {path:"",component:IndexComponent},
  {path:"detail",component:ProductDetailsComponent},
  {path:"payment",component:PaymentComponent},
  {path:"category",component:PropertyCategoryComponent},
  {path:"propertyList",component:ProperyListComponent},
  {path:"seller",component:SellerAgentComponent},
  {path:"submission",component:PropertSubmissionComponent},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
