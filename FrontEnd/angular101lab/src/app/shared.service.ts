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
  getCouList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Courses')
  }

  addCourse(val:any){
    return this.http.post(this.APIUrl+'/Courses', val)
  }

  deleteCourse(val:any){
    return this.http.delete(this.APIUrl+'/Courses'+val)
  }

  getSubList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Subjects')
  }

  addSubject(val:any){
    return this.http.post(this.APIUrl+'/Subjects', val)
  }

  deleteSubject(val:any){
    return this.http.delete(this.APIUrl+'/Subjects'+val)
  }
}
