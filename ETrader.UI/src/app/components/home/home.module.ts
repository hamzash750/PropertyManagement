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
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PreviewAdsComponent } from './preview-ads/preview-ads.component';
import { AgentPropertyComponent } from './agent-property/agent-property.component';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { BuyerPropertyComponent } from './buyer-property/buyer-property.component';
import { PropertyFinderComponent } from './property-finder/property-finder.component';
import { UserAreaComponent } from './user-area/user-area.component';
import { UserfinderComponent } from './userfinder/userfinder.component';
import { NewFinderrequestComponent } from './new-finderrequest/new-finderrequest.component';
import { PropertyReviewsComponent } from './property-reviews/property-reviews.component';
import { UserDashboardComponent } from './user-dashboard/user-dashboard.component';
import { UserChatComponent } from './user-chat/user-chat.component';
import { SenderFormComponent } from './sender-form/sender-form.component';
import { PaymentSuccessfullyComponent } from './payment-successfully/payment-successfully.component';


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
    PropertSubmission4Component,
    PreviewAdsComponent,
    AgentPropertyComponent,
    ContactUsComponent,
    BuyerPropertyComponent,
    PropertyFinderComponent,
    UserAreaComponent,
    UserfinderComponent,
    NewFinderrequestComponent,
    PropertyReviewsComponent,
    UserDashboardComponent,
    UserChatComponent,
    SenderFormComponent,
    PaymentSuccessfullyComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    HomeRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers:[HomeServiceService]
})
export class HomeModule { }
