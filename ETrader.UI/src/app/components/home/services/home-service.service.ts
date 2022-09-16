import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { propertyAdd, propertyReview } from '../models/propertyAdd';
import { environment } from 'src/environments/environment';
@Injectable({
  providedIn: 'root'
})
export class HomeServiceService {
  mainUrl=environment.url_EndPoint;
  constructor(private http: HttpClient) { }
  getAllProperty(): Observable<propertyAdd[]> {
    return this.http.get<propertyAdd[]>(this.mainUrl+'Property/GetAllProperty');
  }
  getPropertyDetails(id:number): Observable<propertyAdd> {
    return this.http.get<propertyAdd>(this.mainUrl+'Property/PropertyDetails?Id='+id);
  }
  getPropertyReviews(id:number): Observable<propertyReview[]> {
    return this.http.get<propertyReview[]>(this.mainUrl+'Property/PropertyReviews?Id='+id);
  }
  getAllPropertyCategory(): Observable<any> {
    return this.http.get<any>(this.mainUrl+'GetAllPropertyCategory');
  }
  getAllAgent(): Observable<any> {
    return this.http.get<any>(this.mainUrl+'GetAllAgent');
  }
  getCategoryProperty(id:number): Observable<propertyAdd[]> {
    return this.http.get<propertyAdd[]>(this.mainUrl+'Property/PropertyCategoryList?Id='+id);
  }
  submitAdd(data:any): Observable<any> {
    return this.http.post(this.mainUrl+'Property/PostAdd',data);
  }
  searchResult(data:any): Observable<any> {
    return this.http.post(this.mainUrl+'SearchProperty',data);
  }
  getLatestProperty(): Observable<propertyAdd[]> {
    return this.http.get<propertyAdd[]>(this.mainUrl+'Property/GetLatestProperty');
  }
  getSellerProperty(id:number): Observable<propertyAdd[]> {
    return this.http.get<propertyAdd[]>(this.mainUrl+'Property/AgentPropertyList?Id='+id);
  }
  deleteSellerProperty(id:number): Observable<any> {
    return this.http.delete<any>(this.mainUrl+'Property/DeleteProperty?Id='+id);
  }
  getBuyerProperty(id:number): Observable<propertyAdd[]> {
    return this.http.get<propertyAdd[]>(this.mainUrl+'Property/BuyerPropertyList?Id='+id);
  }
  getAllFinderRequest(): Observable<any> {
    return this.http.get<any>(this.mainUrl+'PropertyFinder/GetAllFinderRequest');
  }
  saveNewRequest(data:any): Observable<any> {
    return this.http.post(this.mainUrl+'PropertyFinder/NewRequest',data);
  }
  getUserFinderRequest(id:number): Observable<any> {
    return this.http.get<any>(this.mainUrl+'PropertyFinder/GetUserFinderRequest?Id='+id);
  }
  deleteFinderRequest(id:number): Observable<any> {
    return this.http.delete<any>(this.mainUrl+'PropertyFinder/DeleteRequest?Id='+id);
  }
  savePropertyReview(data:any): Observable<any> {
    return this.http.post(this.mainUrl+'PropertyReviews/AddPropertyReview',data);
  }
  getUserDashboard(id:number): Observable<any> {
    return this.http.get<any>(this.mainUrl+'Property/UserDashboardDetails?Id='+id);
  }
  getUserChat(id:number): Observable<any> {
    return this.http.get<any>(this.mainUrl+'Property/UserChatList?Id='+id);
  }
  getUserChatDetails(id:number,buyerId:number): Observable<any> {
    return this.http.get<any>(this.mainUrl+'Property/UserChatDetails?Id='+id+"&buyerId="+buyerId);
  }
  sendNewMessage(data:any): Observable<any> {
    return this.http.post(this.mainUrl+'Property/SaveNewMessage',data);
  }
  submitPayment(data:any): Observable<any> {
    return this.http.post(this.mainUrl+'Payment/PostPaymentToken',data);
  }
}
