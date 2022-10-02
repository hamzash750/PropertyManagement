import { HomeServiceService } from './../services/home-service.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-contact-us',
  templateUrl: './contact-us.component.html',
  styleUrls: ['./contact-us.component.css']
})
export class ContactUsComponent implements OnInit {

  constructor(private _HomeService:HomeServiceService) { }
  name="";
  phone="";
  email="";
  message="";
  ngOnInit(): void {
  }
  sendEmail(){
    let obj={
      name:this.name,
      phone:this.phone,
      email:this.email,
      message:this.message,
    };
    this._HomeService.sendContactUsEmail(obj).subscribe(res=>{
      console.log(res)
      alert("Email Send Successfully to Admin");
      location.href="/home"
    })
  }

}
