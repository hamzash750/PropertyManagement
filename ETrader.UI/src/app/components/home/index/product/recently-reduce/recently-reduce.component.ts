import { Component, OnInit } from '@angular/core';
import { propertyAdd } from '../../../models/propertyAdd';
import { HomeServiceService } from '../../../services/home-service.service';

@Component({
  selector: 'app-recently-reduce',
  templateUrl: './recently-reduce.component.html',
  styleUrls: ['./recently-reduce.component.css']
})
export class RecentlyReduceComponent implements OnInit {

  constructor(private _HomeServiceService:HomeServiceService) { }
  public productList: propertyAdd[] = [];
  ngOnInit(): void {
    this._HomeServiceService.getLatestProperty().subscribe(data=>{
      console.log(data);
      this.productList=data;
    }
    ,error=>{
      console.log(error);
    }
    )
  }


}
