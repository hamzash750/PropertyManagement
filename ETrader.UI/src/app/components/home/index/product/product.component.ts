import { Component, Input, OnInit } from '@angular/core';
import { propertyAdd } from '../../models/propertyAdd';
import { HomeServiceService } from '../../services/home-service.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  constructor(private _HomeServiceService:HomeServiceService) { }
  public productList: propertyAdd[] = [];
  @Input()set searchList(val: any) {
  this.productList=val;
}
  ngOnInit(): void {
    this._HomeServiceService.getAllProperty().subscribe(data=>{
      console.log(data);
      this.productList=data;
    }
    ,error=>{
      console.log(error);
    }
    )
  }

}
