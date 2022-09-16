import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subject } from 'rxjs';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-propert-submission',
  templateUrl: './propert-submission.component.html',
  styleUrls: ['./propert-submission.component.css']
})
export class PropertSubmissionComponent implements OnInit {
  eventsSubject: Subject<void> = new Subject<void>();
  constructor(private _homeService:HomeServiceService,private route:ActivatedRoute) { }
  firstForm=true;
  secondForm=false;
  thirdForm=false;
  forthForm=false;
  ngOnInit(): void {
  }
  stepOne(){
    this.firstForm=true;
    this.secondForm=false;
    this.thirdForm=false;
    this.forthForm=false;
    this.eventsSubject.next();
  }
  stepTwo(){
    this.firstForm=false;
    this.secondForm=true;
    this.thirdForm=false;
    this.forthForm=false;
    this.eventsSubject.next();
  }
  stepThree(){
    this.firstForm=false;
    this.secondForm=false;
    this.thirdForm=true;
    this.forthForm=false;
    this.eventsSubject.next();
  }
  stepFour(){
    this.firstForm=false;
    this.secondForm=false;
    this.thirdForm=false;
    this.forthForm=true;
    this.eventsSubject.next();
  }
  saveProperty(){
    if(localStorage.getItem("userLogin")!=null){
     let  user=JSON.parse(localStorage.getItem("userLogin")?.toString()|| '{}');
      if(localStorage.getItem("newAds")!=null){
        let currentData=JSON.parse(localStorage.getItem("newAds")?.toString()|| '{}');
        let obj={
          id:currentData?.id,
          tittle:  currentData?.title,
          location:  currentData?.address,
          description:  currentData?.description,
          images:currentData?.imagePath,
          price:currentData?.price,
          areaUnit:currentData?.areaUnit,
          area:currentData?.area,
          categoryId:currentData?.type,
          bed:currentData?.bed,
          baths:currentData?.bath,
          kitchen:currentData?.kitchen,
          garage:currentData?.garage=="1"?true:false,
          pool:currentData?.pool=="1"?true:false,
          otherAmenites:currentData?.other,
          sellerId:user?.userID,
          quantity:1,
        };
        this._homeService.submitAdd(obj).subscribe(res=>{
          alert("Add Save Successfully");
          localStorage.removeItem("newAds");
          location.href="/home";
        })
      }
    }else{
      location.href="/home";
    }
    
  }

}
