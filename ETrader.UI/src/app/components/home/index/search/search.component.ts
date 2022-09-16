import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { propertyAdd } from '../../models/propertyAdd';
import { HomeServiceService } from '../../services/home-service.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  @Output() searchResultData = new EventEmitter<any>();
  public allProductList: propertyAdd[] = [];
  propertyCategory:any;
  searchProperty:any;
  constructor(private _HomeServiceService:HomeServiceService) { }
  property="";
  location="";
  status="";
  type=0;
  beds=0;
  bath=0;
  priceMin=0;
  priceMax=0;
  ngOnInit(): void {
    this._HomeServiceService.getAllProperty().subscribe(data=>{
      this.allProductList=data;
    }
    ,error=>{
      console.log(error);
    }
    )
    this._HomeServiceService.getAllPropertyCategory().subscribe(res=>{
      console.log(res)
      this.propertyCategory=res;
    })
  }
  searchResult(){
    let obj={
      property:this.property,
      location:this.location,
      status:this.status,
      type:this.type,
      beds:this.beds,
      bath:this.bath,
      priceMin:this.priceMin,
      priceMax:this.priceMax,
    }
    this._HomeServiceService.searchResult(obj).subscribe(res=>{
      console.log(res)
      this.searchResultData.emit(res);
    })
  }
}
