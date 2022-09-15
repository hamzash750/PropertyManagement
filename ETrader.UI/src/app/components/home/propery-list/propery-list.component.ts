import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { propertyAdd } from '../models/propertyAdd';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-propery-list',
  templateUrl: './propery-list.component.html',
  styleUrls: ['./propery-list.component.css']
})
export class ProperyListComponent implements OnInit {

  public allProductList: propertyAdd[] = [];
  constructor(private _HomeServiceService:HomeServiceService,private route:ActivatedRoute) { }

  ngOnInit(): void {
this.route.queryParamMap.subscribe(parm=>{
  let categoryId=  parm.get("category")?.toString()||'';
  let CatID=parseInt(categoryId);
  this._HomeServiceService.getCategoryProperty(CatID).subscribe(data=>{
    console.log(data);
    this.allProductList=data;
  }
  ,error=>{
    console.log(error);
  }
  )
})

    
  }

}
