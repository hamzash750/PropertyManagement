import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { propertyAdd } from '../models/propertyAdd';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-agent-property',
  templateUrl: './agent-property.component.html',
  styleUrls: ['./agent-property.component.css']
})
export class AgentPropertyComponent implements OnInit {

  public allProductList: propertyAdd[] = [];
  constructor(private _HomeServiceService:HomeServiceService,private route:ActivatedRoute) { }

  ngOnInit(): void {
    if(localStorage.getItem("userLogin")!=null){
      let user=JSON.parse(localStorage.getItem("userLogin")?.toString()|| '{}');
      let UId= user?.userID;
      let UserId=parseInt(UId);
      this._HomeServiceService.getSellerProperty(UserId).subscribe(data=>{
        console.log(data);
        this.allProductList=data;
      }
      ,error=>{
        console.log(error);
      }
      )
    }
  }
deleteProperty(id:any){
  this._HomeServiceService.deleteSellerProperty(id).subscribe(data=>{
    alert("delete Successfully")
    location.href="/home/agentProperty";
  }
  ,error=>{
    console.log(error);
  })
}
editProperty(item:any){
  let obj={
    id:item?.id,
    title:  item?.tittle,
    address:  item?.location,
    description:  item?.description,
    imagePath:item?.images,
    price:item?.price,
    areaUnit:item?.areaUnit,
    area:item?.area,
    type:item?.categoryId,
    bed:item?.bed,
    bath:item?.baths,
    kitchen:item?.kitchen,
    garage:item?.garage==true?"1":"0",
    pool:item?.pool==true?"1":"0",
    other:item?.otherAmenites,
    sellerId:item?.sellerId,
  };
  localStorage.setItem("newAds",JSON.stringify(obj))
  location.href="home/submission";
}
}
