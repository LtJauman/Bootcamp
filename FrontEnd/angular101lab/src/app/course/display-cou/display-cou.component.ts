import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
@Component({
  selector: 'app-display-cou',
  templateUrl: './display-cou.component.html',
  styleUrls: ['./display-cou.component.css']
})
export class DisplayCouComponent implements OnInit {

  constructor(private service:SharedService) {}
  courseList:any=[];

  ngOnInit(): void {
    this.refreshCouList();
  }
  refreshCouList(){
    this.service.getCouList().subscribe(data=>{
      this.courseList = data
    });
  }

}

