import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CompaniesComponent } from './components/companies/companies.component';
import { CommentsComponent } from './components/comments/comments.component';
import { DeleteCommentComponent } from './components/delete-comment/delete-comment.component';
import { UpdateCommentComponent } from './components/update-comment/update-comment.component';
import { CompanyService } from './services/company.service';
import { CommentService } from './services/comment.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    CompaniesComponent,
    CommentsComponent,
    DeleteCommentComponent,
    UpdateCommentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [CompanyService, CommentService],
  bootstrap: [AppComponent]
})
export class AppModule { }
