import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { User } from 'src/app/User';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})
export class AddUserComponent implements OnInit {
  firstName:string | undefined ;
  LastName:string | undefined;
  email:string | undefined;
  address:string | undefined;
  password:string | undefined;
  @Output() userAdd: EventEmitter<User> = new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }
  onSubmit(){
    const user = {
      sno: 1,
      firstName: this.firstName,
      LastName : this.LastName,
      address: this.address,
      email: this.email,
      password: this.password,
      active: true
    }
    this.userAdd.emit(user);

  }

}
