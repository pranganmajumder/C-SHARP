//https://leetcode.com/problems/course-schedule/
// recursive solution : https://paste.ubuntu.com/p/sDBwWhx4fR/

public class Solution {
    
    static bool bfs(ref List<int>[] graph ,ref Dictionary<int,int> pre){
        
        var Q = new Queue<int>() ;
        foreach(KeyValuePair<int,int> t in pre){     //map iteration
            if(t.Value==0)
                Q.Enqueue(t.Key);
            
        }
        while(Q.Count>0){
            int u = Q.Dequeue() ;
            
            for(int i=0 ; i<graph[u].Count ; i++){
                int v = graph[u][i] ;
                
                pre[v]-- ;
                if(pre[v]==0)Q.Enqueue(v) ;
            }
        }
        foreach(KeyValuePair<int,int> t in pre)
            if(t.Value > 0)return false ;
        return true ;
    }
    
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        if(prerequisites.Length == 0)return true ;
        
        
        var pre = new Dictionary<int,int>() ;
        var graph = new List<int>[numCourses] ;
        for(int i=0 ; i<numCourses; i++){
            graph[i] = new List<int>() ;
            pre.Add(i,0) ;
            
        }
        
        for(int i=0 ; i<prerequisites.Length ; i++){
            int u = prerequisites[i][1] ;
            int v = prerequisites[i][0] ;
            
            graph[u].Add(v) ;
            pre[v]++ ;
        }
        return bfs(ref graph, ref pre) ;
    }
}