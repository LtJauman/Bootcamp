import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
@Component({
  selector: 'app-add-stu',
  templateUrl: './add-stu.component.html',
  styleUrls: ['./add-stu.component.css']
})
export class AddStuComponent implements OnInit {

  constructor(private service:SharedService) { }
  @Input() stu:any;
  studentId!:string;
  firstName!: string;
  lastName!: string;
  ngOnInit(): void {
    this.studentId=this.stu.studentId;
    this.firstName=this.stu.firstName;
    this.lastName=this.stu.lastName;
  }

  addStudent(){ 
    var val = {firstName:this.firstName,
    lastName:this.lastName}
    this.service.addStudent(val).subscribe(res=>{
      alert(res.toString())
    })
  }

}
