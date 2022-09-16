import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user-area',
  templateUrl: './user-area.component.html',
  styleUrls: ['./user-area.component.css']
})
export class UserAreaComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
    if(localStorage.getItem("userLogin")==null){
location.href="/authorization/login"
    }
  }

}
