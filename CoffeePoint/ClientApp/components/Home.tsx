import * as React from 'react';
import { RouteComponentProps } from 'react-router-dom';

export default class Home extends React.Component<RouteComponentProps<{}>, { items: any; text: any }> {
    constructor(props: any) {
        super(props);
        this.state = {
            items: [],
            text: ''
        };
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    public handleSubmit(e: any) {
        e.preventDefault();
        if (!this.state.text.length) {
            return;
        }
        const newItem = {
            text: this.state.text,
            id: Date.now()
        };
        this.setState(prevState => ({
            items: prevState.items.concat(newItem),
            text: ''
        }));
    }

    public render() {
        return <div>
            <form className="form-horizontal" onSubmit={this.handleSubmit}>
                       <div className="form-group">
                           <label htmlFor="inputEmail3" className="col-sm-2 control-label">Email</label>
                           <div className="col-sm-10">
                               <input type="email" className="form-control" id="inputEmail3" placeholder="Email"/>
                           </div>
                       </div>
                       <div className="form-group">
                           <label htmlFor="inputPassword3" className="col-sm-2 control-label">Password</label>
                           <div className="col-sm-10">
                                <input type="password" className="form-control" id="inputPassword3"
                                    placeholder="Password"/>
                           </div>
                       </div>
                       <div className="form-group">
                           <div className="col-sm-offset-2 col-sm-10">
                               <div className="checkbox">
                                   <label><input type="checkbox" value="Remember me"/></label>
                               </div>
                           </div>
                       </div>
                       <div className="form-group">
                           <div className="col-sm-offset-2 col-sm-10">
                               <button type="submit" className="btn btn-default">Sign in</button>
                           </div>
                       </div>
                   </form>
        </div>;
    }
}