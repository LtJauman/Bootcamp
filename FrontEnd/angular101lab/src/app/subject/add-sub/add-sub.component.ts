import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-add-sub',
  templateUrl: './add-sub.component.html',
  styleUrls: ['./add-sub.component.css']
})
export class AddSubComponent implements OnInit {

  constructor(private service:SharedService) {}
  @Input() sub:any;
  @Output() subjectAdded: EventEmitter<any> = new EventEmitter();

  subjectId!:string;
  subjectName!: string;
  subjectDescription!: string;
  courseId!: string;

  ngOnInit(): void {
    this.subjectId=this.sub.subjectId;
    this.subjectName=this.sub.subjectName;
    this.subjectDescription=this.sub.subjectDescription;
    this.courseId="1"; 
  }

  addSubject(){ 
    var val = {subjectName:this.subjectName,
    subjectDescription:this.subjectDescription,courseId:this.courseId}
    this.service.addSubject(val).subscribe(response => {
      this.subjectAdded.emit();
    });
  }
}
