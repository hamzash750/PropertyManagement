import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-payment-successfully',
  templateUrl: './payment-successfully.component.html',
  styleUrls: ['./payment-successfully.component.css']
})
export class PaymentSuccessfullyComponent implements OnInit {
  constructor(private _homeService:HomeServiceService,private route:ActivatedRoute) { }
  ngOnInit(): void {
    if(localStorage.getItem("token")!=null){
      let  token=JSON.parse(localStorage.getItem("token")?.toString()|| '{}');
      debugger
      this.makePaymentCall(token?.name,token?.token,token?.price,token?.sellerId,token?.propertyId,);
    
    }
  }
  paymentSuccess=false;
  makePaymentCall(name:string,token:string,amount:number,seller:string,propertyId:number){
    if(localStorage.getItem("userLogin")!=null){
      let  user=JSON.parse(localStorage.getItem("userLogin")?.toString()|| '{}');
      let obj={
        propertyId:propertyId,
        product:name,
        token:token,
        amount:amount,
        buyerId:user?.userID,
        sellerId:seller
      };
      this._homeService.submitPayment(obj).subscribe(res=>{
        this.paymentSuccess=true;
        localStorage.removeItem("token");
      })
    }
   
  }
}
