import { SenderFormComponent } from './sender-form/sender-form.component';
import { PropertyReviewsComponent } from './property-reviews/property-reviews.component';
import { propertyReview } from './models/propertyAdd';
import { NewFinderrequestComponent } from './new-finderrequest/new-finderrequest.component';
import { UserAreaComponent } from './user-area/user-area.component';
import { PropertyFinderComponent } from './property-finder/property-finder.component';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { AgentPropertyComponent } from './agent-property/agent-property.component';
import { PreviewAdsComponent } from './preview-ads/preview-ads.component';
import { PropertSubmissionComponent } from './propert-submission/propert-submission.component';
import { SellerAgentComponent } from './seller-agent/seller-agent.component';
import { ProperyListComponent } from './propery-list/propery-list.component';
import { PropertyCategoryComponent } from './property-category/property-category.component';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IndexComponent } from './index/index.component';
import { PaymentComponent } from './payment/payment.component';
import { BuyerPropertyComponent } from './buyer-property/buyer-property.component';
import { PaymentSuccessfullyComponent } from './payment-successfully/payment-successfully.component';

const routes: Routes = [
  {path:"",component:IndexComponent},
  {path:"detail",component:ProductDetailsComponent},
  {path:"payment",component:PaymentComponent},
  {path:"category",component:PropertyCategoryComponent},
  {path:"propertyList",component:ProperyListComponent},
  {path:"seller",component:SellerAgentComponent},
  {path:"submission",component:PropertSubmissionComponent},
  {path:"preview",component:PreviewAdsComponent},
  {path:"agentProperty",component:AgentPropertyComponent},
  {path:"contact",component:ContactUsComponent},
  {path:"buyerProperty",component:BuyerPropertyComponent},
  {path:"propertyFinder",component:PropertyFinderComponent},
  {path:"userArea",component:UserAreaComponent},
  {path:"newRequest",component:NewFinderrequestComponent},
  {path:"propertyReviews",component:PropertyReviewsComponent},
  {path:"sellerContact",component:SenderFormComponent},
  {path:"paymentSuccessfully",component:PaymentSuccessfullyComponent},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
