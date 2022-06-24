import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
@Component({
  selector: 'app-add-sub',
  templateUrl: './add-sub.component.html',
  styleUrls: ['./add-sub.component.css']
})
export class AddSubComponent implements OnInit {

  constructor(private service:SharedService) {}
  @Input() sub:any;
  subjectId!:string;
  subjectName!: string;
  subjectDescription!: string;
  ngOnInit(): void {
    this.subjectId=this.sub.subjectId;
    this.subjectName=this.sub.subjectName;
    this.subjectDescription=this.sub.subjectDescription;
  }

  addSubject(){
    var val = {subjectName:this.subjectName,
    subjectDescription:this.subjectDescription}
    this.service.addSubject(val).subscribe(res=>{
      alert(res.toString())
    })
  }

}
