import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { propertyAdd } from '../models/propertyAdd';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-buyer-property',
  templateUrl: './buyer-property.component.html',
  styleUrls: ['./buyer-property.component.css']
})
export class BuyerPropertyComponent implements OnInit {

  public allProductList: propertyAdd[] = [];
  constructor(private _HomeServiceService:HomeServiceService,private route:ActivatedRoute) { }

  ngOnInit(): void {
    if(localStorage.getItem("userLogin")!=null){
      let user=JSON.parse(localStorage.getItem("userLogin")?.toString()|| '{}');
      let UId= user?.userID;
      let UserId=parseInt(UId);
      this._HomeServiceService.getBuyerProperty(UserId).subscribe(data=>{
        console.log(data);
        this.allProductList=data;
      }
      ,error=>{
        console.log(error);
      }
      )
    }
  }
}
