import { Component, OnInit } from '@angular/core';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-userfinder',
  templateUrl: './userfinder.component.html',
  styleUrls: ['./userfinder.component.css']
})
export class UserfinderComponent implements OnInit {

  constructor(private _HomeServiceService:HomeServiceService) { }
  finderRequest:any;
  ngOnInit(): void {
    if(localStorage.getItem("userLogin")!=null){
      let  user=JSON.parse(localStorage.getItem("userLogin")?.toString()|| '{}');
    this._HomeServiceService.getUserFinderRequest(user?.userID).subscribe(res=>{
      console.log(res)
      this.finderRequest=res;
    })
  }
}
deleteReqeuset(id:any){
  this._HomeServiceService.deleteFinderRequest(id).subscribe(res=>{
    alert("Request Delete Successfully")
    location.href="/home/userArea"
  })
}

}
