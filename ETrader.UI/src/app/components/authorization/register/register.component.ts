import { AfterViewInit, Component, OnInit, OnDestroy } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { AuthorizationService } from '../services/authorization.service';
const url = 'assets/js/mymain.js';
declare var $:any;
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit,OnDestroy,AfterViewInit {

  constructor(private formBuilder: FormBuilder,private _AuthorizationService:AuthorizationService) { }

  registerForm = this.formBuilder.group({
    name: ['', [Validators.required,]],
    phone: ['', [Validators.required,]],
    address: ['', [Validators.required,]],
    email: ['', [Validators.required, Validators.email]],
    password: ['', [Validators.required, Validators.minLength(6)]],
    accountType: ['', [Validators.required,]]
  
  }
   
);
 
  ngOnInit(): void {
  }
  registerLogin(){
console.log("Regsiter CLick")
this._AuthorizationService.RegisterUser(this.registerForm.value).subscribe(res=>{
  console.log(res)
  alert("User Register Successfully");
  location.href="/home";
})
  }
  changeAccountType(e: any) {
    debugger
    this.registerForm.controls["accountType"].setValue(e.target.value, {
      onlySelf: true,
    });
  }
  ngAfterViewInit(): void {
    //Called after ngAfterContentInit when the component's view has been initialized. Applies to components only.
    //Add 'implements AfterViewInit' to the class.
    setTimeout(() => {
      this.loadScript();
    }, 500);
  }
  public loadScript() {
    let node = document.createElement('script');
    node.src = url;
    node.id="mainScript";
    node.type = 'text/javascript';
    node.async = true;
    node.charset = 'utf-8';
    document.getElementsByTagName('head')[0].appendChild(node);
  }
  ngOnDestroy(): void {
    $('#mainScript').remove();
  }
}