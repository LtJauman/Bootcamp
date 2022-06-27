import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
@Component({
  selector: 'app-add-cou',
  templateUrl: './add-cou.component.html',
  styleUrls: ['./add-cou.component.css']
})
export class AddCouComponent implements OnInit {

  constructor(private service:SharedService) { }

  @Input() cou:any;
  courseId!:string;
  courseName!: string;
  courseDescription!: string;
  ngOnInit(): void {
    this.courseId=this.cou.courseId;
    this.courseName=this.cou.courseName;
    this.courseDescription=this.cou.courseDescription;
  }

  addCourse(){ 
    var val = {courseName:this.courseName,
      courseDescription:this.courseDescription}
    this.service.addCourse(val).subscribe(res=>{
      alert(res.toString())
    })
  } //I want it so that when this method gets called, the modal disappears

}
