import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-propert-submission1',
  templateUrl: './propert-submission1.component.html',
  styleUrls: ['./propert-submission1.component.css']
})
export class PropertSubmission1Component implements OnInit {

  constructor(private formBuilder: FormBuilder,) { }
  @Input() events!: Observable<void>;
  submissionForm = this.formBuilder.group({
    title: ['', [Validators.required]],
    address: ['', [Validators.required,]],
    description: ['', [Validators.required,]],
  }
);
  ngOnInit(): void {
    if(localStorage.getItem("newAds")!=null){
      let currentData=JSON.parse(localStorage.getItem("newAds")?.toString()|| '{}');
      this.submissionForm.controls["title"].setValue(currentData?.title);
      this.submissionForm.controls["address"].setValue(currentData?.address);
      this.submissionForm.controls["description"].setValue(currentData?.description);
    }
     this.events.subscribe(() => this.saveData());
  }
  saveData(){
    if(localStorage.getItem("newAds")!=null){
      let currentData=JSON.parse(localStorage.getItem("newAds")?.toString()|| '{}');
      let obj={
        id:currentData?.id,
        title:  this.submissionForm.controls["title"].value,
        address: this.submissionForm.controls["address"].value,
        description:  this.submissionForm.controls["description"].value,
        imagePath:currentData?.imagePath,
        price:currentData?.price,
        areaUnit:currentData?.areaUnit,
        area:currentData?.area,
        type:currentData?.type,
        bed:currentData?.bed,
        bath:currentData?.bath,
        kitchen:currentData?.kitchen,
        garage:currentData?.garage,
        pool:currentData?.pool,
        other:currentData?.other,
      };
      localStorage.setItem("newAds",JSON.stringify(obj))
    }else{
      localStorage.setItem("newAds",JSON.stringify(this.submissionForm.value))
    }
  

  }
}
