import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
@Component({
  selector: 'app-display-stu',
  templateUrl: './display-stu.component.html',
  styleUrls: ['./display-stu.component.css']
})
export class DisplayStuComponent implements OnInit {

  constructor(private service:SharedService) { }
  studentList:any =[];

  ngOnInit(): void {
  }
  refreshStuList(){
    // this.service.getStuList().subscribe(data)
  }
}
