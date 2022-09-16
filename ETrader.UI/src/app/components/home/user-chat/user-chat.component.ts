import { Component, OnInit } from '@angular/core';
import { HomeServiceService } from '../services/home-service.service';

@Component({
  selector: 'app-user-chat',
  templateUrl: './user-chat.component.html',
  styleUrls: ['./user-chat.component.css']
})
export class UserChatComponent implements OnInit {
  public userChat: any;
  constructor(private _HomeServiceService:HomeServiceService) { }

  ngOnInit(): void {
    if(localStorage.getItem("userLogin")!=null){
      let user=JSON.parse(localStorage.getItem("userLogin")?.toString()|| '{}');
      let UId= user?.userID;
      let UserId=parseInt(UId);
      this._HomeServiceService.getUserChat(UserId).subscribe(data=>{
        this.userChat=data;
        if(this.userChat.length>0){
          this.showUserChat(this.userChat[0]?.userId);
        }
       
        console.log(this.userChat)
      }
      ,error=>{
        console.log(error);
      }
      )
    }
  }
  userChatDetails:any;
  currentSeller=0;
  currentBuyer=0;
  message="";
  showUserChat(id:any){
    if(localStorage.getItem("userLogin")!=null){
      let user=JSON.parse(localStorage.getItem("userLogin")?.toString()|| '{}');
      let UId= user?.userID;
      let UserId=parseInt(UId);
      this.currentBuyer=UserId;
      this.currentSeller=id;
      this._HomeServiceService.getUserChatDetails(id,UserId).subscribe(data=>{
        this.userChatDetails=data;
        console.log(this.userChatDetails)
      }
      ,error=>{
        console.log(error);
      }
      )
    }
  }
  sendMessage(){
    if(localStorage.getItem("userLogin")!=null){
      let  user=JSON.parse(localStorage.getItem("userLogin")?.toString()|| '{}');
      let obj={
        "sellerId": this.currentSeller,
        "buyerId":this.currentBuyer,
        "message": this.message,
      };
      this._HomeServiceService.sendNewMessage(obj).subscribe(res=>{
        location.href="/home/userArea"
      })
    }
    else{
      location.href="/home";
    }
  }
}