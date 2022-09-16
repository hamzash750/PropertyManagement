import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-preview-ads',
  templateUrl: './preview-ads.component.html',
  styleUrls: ['./preview-ads.component.css']
})
export class PreviewAdsComponent implements OnInit {

  constructor() { }
  propertyDetails:any;
  other:any=[];
  ngOnInit(): void {
    if(localStorage.getItem("newAds")!=null){
      this.propertyDetails=JSON.parse(localStorage.getItem("newAds")?.toString()|| '{}')
      this.other=JSON.parse(this.propertyDetails?.other)
    }else{

    }
  }
  checkValue(value:string):boolean{
    if(this.other!=undefined&&this.other!=null&& this.other.length>0){
      if(this.other.findIndex((x: string)=>x==value)>=0){
        return true;
      }else{
        return false;
      }
    }else{
      return false;
    }
  
  }
}
