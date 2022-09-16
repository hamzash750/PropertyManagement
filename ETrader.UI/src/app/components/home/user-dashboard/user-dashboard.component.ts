import { Component, OnInit } from '@angular/core';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-user-dashboard',
  templateUrl: './user-dashboard.component.html',
  styleUrls: ['./user-dashboard.component.css']
})
export class UserDashboardComponent implements OnInit {

  public dashboardData:any
  constructor(private _HomeServiceService:HomeServiceService,) { }

  ngOnInit(): void {
    if(localStorage.getItem("userLogin")!=null){
      let user=JSON.parse(localStorage.getItem("userLogin")?.toString()|| '{}');
      let UId= user?.userID;
      let UserId=parseInt(UId);
      this._HomeServiceService.getUserDashboard(UserId).subscribe(data=>{
        console.log(data);
        this.dashboardData=data;
      }
      ,error=>{
        console.log(error);
      }
      )
    }
  }
}
