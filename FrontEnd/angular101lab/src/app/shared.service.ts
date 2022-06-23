import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'; 
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly APIUrl = "https://localhost:44302/api/StudentEnrolment";
  

  constructor(private http:HttpClient) { }

  getStuList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Students')
  }

  addStudent(val:any){
    return this.http.post(this.APIUrl+'/Students', val)
  }

  deleteStudent(val:any){
    return this.http.delete(this.APIUrl+'/Students'+val)
  }
}
