import { Component, OnInit } from '@angular/core';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-seller-agent',
  templateUrl: './seller-agent.component.html',
  styleUrls: ['./seller-agent.component.css']
})
export class SellerAgentComponent implements OnInit {

  constructor(private _HomeServiceService:HomeServiceService) { }
  allAgent:any;
  ngOnInit(): void {
    this._HomeServiceService.getAllAgent().subscribe(res=>{
      console.log(res)
      this.allAgent=res;
    });
    
  }
 
}
