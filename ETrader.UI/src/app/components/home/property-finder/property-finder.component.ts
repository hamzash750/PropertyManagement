import { Component, OnInit } from '@angular/core';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-property-finder',
  templateUrl: './property-finder.component.html',
  styleUrls: ['./property-finder.component.css']
})
export class PropertyFinderComponent implements OnInit {
  constructor(private _HomeServiceService:HomeServiceService) { }
  finderRequest:any;
  ngOnInit(): void {
    this._HomeServiceService.getAllFinderRequest().subscribe(res=>{
      console.log(res)
      this.finderRequest=res;
    })
  }

}
