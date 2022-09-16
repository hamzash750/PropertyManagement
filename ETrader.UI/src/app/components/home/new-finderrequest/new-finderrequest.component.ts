import { Component, OnInit } from '@angular/core';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-new-finderrequest',
  templateUrl: './new-finderrequest.component.html',
  styleUrls: ['./new-finderrequest.component.css']
})
export class NewFinderrequestComponent implements OnInit {

  constructor(private _HomeServiceService:HomeServiceService) { }
  finderRequest:any;
  ngOnInit(): void {

  }
  title="";
  description="";
  price=0;
saveRequest(){
  if(localStorage.getItem("userLogin")!=null){
    let  user=JSON.parse(localStorage.getItem("userLogin")?.toString()|| '{}');
    let obj={
      userId:user?.userID,
      title:this.title,
      description:this.description,
      priceExpectations:this.price
    };
    this._HomeServiceService.saveNewRequest(obj).subscribe(res=>{
      location.href="/home/propertyFinder"
    })
  }
  else{
    location.href="/home";
  }
}
}
