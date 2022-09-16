import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.css']
})
export class NavigationComponent implements OnInit {

  constructor() { }
  user:any;
  ngOnInit(): void {
    if(localStorage.getItem("userLogin")!=null){
      this.user=JSON.parse(localStorage.getItem("userLogin")?.toString()|| '{}');
    }else{
      this.user=null;
    }
  }
  logoutUser(){
    localStorage.clear();
    location.href="/home";
  }
  newSubmission(){
    localStorage.removeItem("newAds");
    location.href="/home/submission"; 
  }

}
