import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { propertyAdd, propertyReview } from '../models/propertyAdd';
@Injectable({
  providedIn: 'root'
})
export class HomeServiceService {
  constructor(private http: HttpClient) { }
  getAllProperty(): Observable<propertyAdd[]> {
    return this.http.get<propertyAdd[]>('https://localhost:44359/Property/GetAllProperty');
  }
  getPropertyDetails(id:number): Observable<propertyAdd> {
    return this.http.get<propertyAdd>('https://localhost:44359/Property/PropertyDetails?Id='+id);
  }
  getPropertyReviews(id:number): Observable<propertyReview[]> {
    return this.http.get<propertyReview[]>('https://localhost:44359/Property/PropertyReviews?Id='+id);
  }
  getAllPropertyCategory(): Observable<any> {
    return this.http.get<any>('https://localhost:44359/GetAllPropertyCategory');
  }
  getAllAgent(): Observable<any> {
    return this.http.get<any>('https://localhost:44359/GetAllAgent');
  }
  getCategoryProperty(id:number): Observable<propertyAdd[]> {
    return this.http.get<propertyAdd[]>('https://localhost:44359/Property/PropertyCategoryList?Id='+id);
  }
}
