import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { IndexComponent } from './index/index.component';
import { HeaderComponent } from './index/header/header.component';
import { SearchComponent } from './index/search/search.component';
import { ProductComponent } from './index/product/product.component';
import { CalculatorComponent } from './index/product/calculator/calculator.component';
import { RecentlyReduceComponent } from './index/product/recently-reduce/recently-reduce.component';
import { HomeServiceService } from './services/home-service.service';
import { HttpClientModule } from '@angular/common/http';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { PaymentComponent } from './payment/payment.component';
import { PropertyCategoryComponent } from './property-category/property-category.component';
import { ProperyListComponent } from './propery-list/propery-list.component';
import { SellerAgentComponent } from './seller-agent/seller-agent.component';
import { PropertSubmission1Component } from './propert-submission1/propert-submission1.component';
import { PropertSubmission2Component } from './propert-submission2/propert-submission2.component';
import { PropertSubmission3Component } from './propert-submission3/propert-submission3.component';
import { PropertSubmissionComponent } from './propert-submission/propert-submission.component';
import { PropertSubmission4Component } from './propert-submission4/propert-submission4.component';


@NgModule({
  declarations: [
    IndexComponent,
    HeaderComponent,
    SearchComponent,
    ProductComponent,
    CalculatorComponent,
    RecentlyReduceComponent,
    ProductDetailsComponent,
    PaymentComponent,
    PropertyCategoryComponent,
    ProperyListComponent,
    SellerAgentComponent,
    PropertSubmission1Component,
    PropertSubmission2Component,
    PropertSubmission3Component,
    PropertSubmissionComponent,
    PropertSubmission4Component
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    HomeRoutingModule
  ],
  providers:[HomeServiceService]
})
export class HomeModule { }
