import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
@Component({
  selector: 'app-display-sub',
  templateUrl: './display-sub.component.html',
  styleUrls: ['./display-sub.component.css']
})
export class DisplaySubComponent implements OnInit {

  constructor(private service:SharedService) { }
  subjectList:any=[];
  ngOnInit(): void {
    this.refreshSubList();
  }
  refreshSubList(){
    this.service.getSubList().subscribe(data=>{
      this.subjectList = data
    });
  }
}


