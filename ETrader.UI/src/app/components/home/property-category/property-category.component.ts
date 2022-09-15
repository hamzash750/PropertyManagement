import { Component, OnInit } from '@angular/core';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-property-category',
  templateUrl: './property-category.component.html',
  styleUrls: ['./property-category.component.css']
})
export class PropertyCategoryComponent implements OnInit {

  constructor(private _HomeServiceService:HomeServiceService) { }
  propertyCategory:any;
  ngOnInit(): void {
    this._HomeServiceService.getAllPropertyCategory().subscribe(res=>{
      console.log(res)
      this.propertyCategory=res;
    })
  }

}
