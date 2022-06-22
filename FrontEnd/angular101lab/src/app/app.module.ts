import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StudentComponent } from './student/student.component';
import { DisplayStuComponent } from './student/display-stu/display-stu.component';
import { AddStuComponent } from './student/add-stu/add-stu.component';
import { CourseComponent } from './course/course.component';
import { DisplayCouComponent } from './course/display-cou/display-cou.component';
import { AddCouComponent } from './course/add-cou/add-cou.component';
import { SubjectComponent } from './subject/subject.component';
import { DisplaySubComponent } from './subject/display-sub/display-sub.component';
import { AddSubComponent } from './subject/add-sub/add-sub.component';

@NgModule({
  declarations: [
    AppComponent,
    StudentComponent,
    DisplayStuComponent,
    AddStuComponent,
    CourseComponent,
    DisplayCouComponent,
    AddCouComponent,
    SubjectComponent,
    DisplaySubComponent,
    AddSubComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
