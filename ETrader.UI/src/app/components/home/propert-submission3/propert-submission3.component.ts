import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-propert-submission3',
  templateUrl: './propert-submission3.component.html',
  styleUrls: ['./propert-submission3.component.css']
})
export class PropertSubmission3Component implements OnInit {
  @Input() events!: Observable<void>;
  constructor(private _HomeServiceService:HomeServiceService,private formBuilder: FormBuilder) { }
  submissionFormSec = this.formBuilder.group({
    price: ['', [Validators.required]],
    areaUnit: ['', [Validators.required,]],
    area: ['', [Validators.required,]],
    type: ['', [Validators.required,]],
    bed: ['', [Validators.required,]],
    bath: ['', [Validators.required,]],
    kitchen: ['', [Validators.required,]],
    garage: ['', [Validators.required,]],
    pool: ['', [Validators.required,]],
    other: ['', [Validators.required,]],
  });
  propertyCategory:any;
  ngOnInit(): void {
    this._HomeServiceService.getAllPropertyCategory().subscribe(res=>{
      console.log(res)
      this.propertyCategory=res;
      if(localStorage.getItem("newAds")!=null){
        let currentData=JSON.parse(localStorage.getItem("newAds")?.toString()|| '{}');
        this.submissionFormSec.controls["price"].setValue(currentData?.price);
        this.submissionFormSec.controls["areaUnit"].setValue(currentData?.areaUnit);
        this.submissionFormSec.controls["area"].setValue(currentData?.area);
        this.submissionFormSec.controls["type"].setValue(currentData?.type);
        this.submissionFormSec.controls["bed"].setValue(currentData?.bed);
        this.submissionFormSec.controls["bath"].setValue(currentData?.bath);
        this.submissionFormSec.controls["kitchen"].setValue(currentData?.kitchen);
        this.submissionFormSec.controls["garage"].setValue(currentData?.garage);
        this.submissionFormSec.controls["pool"].setValue(currentData?.pool);
        this.submissionFormSec.controls["other"].setValue(currentData?.other);
        this.other=JSON.parse(currentData?.other);
      }

    });
    this.events.subscribe(() => this.saveData());
  }
  saveData(){
    if(localStorage.getItem("newAds")!=null){
      let currentData=JSON.parse(localStorage.getItem("newAds")?.toString()|| '{}');
      let obj={
        id:currentData?.id,
        title:  currentData?.title,
        address:  currentData?.address,
        description:  currentData?.description,
        imagePath:currentData?.imagePath,
        price:this.submissionFormSec.controls["price"].value,
        areaUnit:this.submissionFormSec.controls["areaUnit"].value,
        area:this.submissionFormSec.controls["area"].value,
        type:this.submissionFormSec.controls["type"].value,
        bed:this.submissionFormSec.controls["bed"].value,
        bath:this.submissionFormSec.controls["bath"].value,
        kitchen:this.submissionFormSec.controls["kitchen"].value,
        garage:this.submissionFormSec.controls["garage"].value,
        pool:this.submissionFormSec.controls["pool"].value,
        other:JSON.stringify(this.other)
      };
      localStorage.setItem("newAds",JSON.stringify(obj))
    }
  }
  other:any=[];
saveOther(value:string){
  if(this.other!=undefined&& this.other.length>0){
    if(this.other.findIndex((x: string)=>x==value)>=0){
      let index=this.other.findIndex((x: string)=>x==value)
      this.other.splice(index, 1);
    }else{
      this.other.push(value);
    }
  }else{
    this.other.push(value);
  }

 console.log(this.other)
}
checkValue(value:string):boolean{
  if(this.other!=undefined&&this.other!=null&& this.other.length>0){
    if(this.other.findIndex((x: string)=>x==value)>=0){
      return true;
    }else{
      return false;
    }
  }else{
    return false;
  }

}
}
