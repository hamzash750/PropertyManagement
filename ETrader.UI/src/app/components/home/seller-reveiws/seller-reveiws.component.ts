import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-seller-reveiws',
  templateUrl: './seller-reveiws.component.html',
  styleUrls: ['./seller-reveiws.component.css']
})
export class SellerReveiwsComponent implements OnInit {

  constructor(private _HomeServiceService:HomeServiceService,private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.route.queryParams.subscribe(parm => {

      this.getAgent(Number(parm["id"]));
    });

  }
  item:any;
  allProductReviews:any;
  getReviews(sellerId:number){
    this._HomeServiceService.getPropertyReviews(Number( sellerId)).subscribe(data=>{
      this.allProductReviews=data;
    });
  }

  getAgent(id:number){
    this._HomeServiceService.getAllAgent().subscribe(res=>{
      console.log(res)
      var find=res.find((x: { id: number; })=>x.id==id);
      if(find!=null){
        this.item=find;
        this.getReviews(this.item?.id)
      }
     
    });
  }
  checkProductRating(rating:number=0){
    return rating;
     }
}
