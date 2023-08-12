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
  ModalTitle!: string;
  ActivateAddEditSubComp:boolean=false; 
  sub:any;

  ngOnInit(): void {
    this.refreshSubList();
  }

  addClick(){
    this.sub={
      subjectId: 0,
      subjectName:"",
      subjectDescription:"",
      courseId:""
    }
    this.ModalTitle="Add Subject";
    this.ActivateAddEditSubComp=true;
  }
  deleteClick(item: { subjectId: any; }){
    if(confirm("Are you sure you want to do this?")){
      this.service.deleteSubject(item.subjectId).subscribe(data =>{
        alert(data.toString());
        this.refreshSubList();
      }
        )
    }
  }
  closeClick(){
    this.ActivateAddEditSubComp=false;
    this.refreshSubList();
  }
  refreshSubList(){
    this.service.getSubList().subscribe(data=>{
      this.subjectList = data
    });
  }
}


