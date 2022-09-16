import { Component, Input, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-propert-submission2',
  templateUrl: './propert-submission2.component.html',
  styleUrls: ['./propert-submission2.component.css']
})
export class PropertSubmission2Component implements OnInit {
  imageSrc: string | undefined;
  constructor() { }
  @Input() events!: Observable<void>;
  ngOnInit(): void {
    if(localStorage.getItem("newAds")!=null){
      let currentData=JSON.parse(localStorage.getItem("newAds")?.toString()|| '{}');
      this.imageSrc=currentData?.imagePath
    }
    this.events.subscribe(() => this.saveData());
  }
  onFileChange(event:any) {
    const reader = new FileReader();
    
    if(event.target.files && event.target.files.length) {
      const [file] = event.target.files;
      reader.readAsDataURL(file);
    
      reader.onload = () => {
   
        this.imageSrc = reader.result as string;
     
       console.log(reader.result)
      };
   
    }
  }
  saveData(){
    if(localStorage.getItem("newAds")!=null){
      let currentData=JSON.parse(localStorage.getItem("newAds")?.toString()|| '{}');
      let obj={
        id:currentData?.id,
        title:  currentData?.title,
        address:  currentData?.address,
        description:  currentData?.description,
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
        imagePath:this.imageSrc
      };
      localStorage.setItem("newAds",JSON.stringify(obj))
    }
   

  }
}
