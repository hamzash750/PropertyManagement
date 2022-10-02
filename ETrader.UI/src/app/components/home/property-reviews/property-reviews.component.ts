import { ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-property-reviews',
  templateUrl: './property-reviews.component.html',
  styleUrls: ['./property-reviews.component.css']
})
export class PropertyReviewsComponent implements OnInit {

  constructor(private _HomeServiceService:HomeServiceService,private route:ActivatedRoute) { }
  finderRequest:any;
  ngOnInit(): void {

  }
  title="";
  description="";
  rate=0;
saveRequest(){
  
  this.route.queryParams.subscribe(parm => {

    if(localStorage.getItem("userLogin")!=null){
      let  user=JSON.parse(localStorage.getItem("userLogin")?.toString()|| '{}');
      let obj={
        "propertyId": 0,
        "userId": user?.userID,
        "rate": this.rate,
        "reviewTittle": this.title,
        "reviewComents": this.description,
        "sellerId":Number(parm["Id"])
      }
      this._HomeServiceService.savePropertyReview(obj).subscribe(res=>{
        location.href="/home/detail?id="+Number(parm["propertyId"])
      })
    }
    else{
      location.href="/home";
    }
  })
}
}