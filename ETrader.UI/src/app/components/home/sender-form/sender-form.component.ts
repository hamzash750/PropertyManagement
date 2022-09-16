import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-sender-form',
  templateUrl: './sender-form.component.html',
  styleUrls: ['./sender-form.component.css']
})
export class SenderFormComponent implements OnInit {

  constructor(private _HomeServiceService:HomeServiceService,private route:ActivatedRoute) { }
  finderRequest:any;
  ngOnInit(): void {
}
  message="";
sendNewMessage(){
  this.route.queryParams.subscribe(parm => {
  if(localStorage.getItem("userLogin")!=null){
    let  user=JSON.parse(localStorage.getItem("userLogin")?.toString()|| '{}');
    let obj={
      "sellerId": Number(parm["Id"]),
      "buyerId":user?.userID,
      "message": this.message,
    };
    this._HomeServiceService.sendNewMessage(obj).subscribe(res=>{
      location.href="/home/userArea"
    })
  }
  else{
    location.href="/home";
  }
})
}
}
